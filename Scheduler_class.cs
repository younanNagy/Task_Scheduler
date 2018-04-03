    ////////////////////////////////////////////////////////////////////////////////////////////////
    // All what you need to use this class is to fill "tasks" list and set the scheduling mode by //
    //mode="Priority" smaller                                                                     //
    //mode="FCFS" ->First Come First Serve                                                        //
    //mode="SJF" -> shortest job first                                                            //
    //mode="SJF-Preemptive" -> shortest job first preemptive                                      //
    //mode="Priority-Preemptive"                                                                  //
    //mode="Round_Robin" set the burst variable to determine the round quantum                    //
    //then call Schedule Function                                                                 //
    //you will find the detailed output in "finished_tasks" List                                  //
    ////////////////////////////////////////////////////////////////////////////////////////////////
class schedular
{
    public int no_tasks;
    public float Timer;
    public float Ave_wating_time;
    task running_task;
    public string mode;
    public static string sort_by;
    public List<task> tasks;
    private List<task> current_tasks;
    public List<task> finished_tasks;
    private Dictionary<float, List<task>> tasks_map;
    private Queue<task> round_robin_queue;
    public float burst;
    //---------------------------------------------------------------------//constructor
    public schedular()//constructor
    {
        sort_by = "arrival_time";
        no_tasks = 0;
        Timer = 0;
        tasks = new List<task>();
        current_tasks = new List<task>();
        finished_tasks = new List<task>();
        tasks_map = new Dictionary<float, List<task>>();
        running_task = new task();
        round_robin_queue = new Queue<task>();
        burst = 5;
        mode = "FCFS";
        Ave_wating_time = 0;

    }
    public void sort()
    {
        tasks.Sort();
    }
    private void fill_tasks_map()
    {
        sort_by = "arrival_time";//so Sort function will sort according the arrival time 
        tasks.Sort();
        foreach (var t in tasks)
        {
            if (!tasks_map.ContainsKey(t.arrival_time))
            {
                List<task> temp = new List<task> { t };
                tasks_map.Add(t.arrival_time, temp);
            }
            else
                tasks_map[t.arrival_time].Add(t);
        }
         if (mode == "SJF" || mode == "SJF-Preemptive")
                sort_by = "remaining_time";
            else if (mode == "priority" || mode == "Priority-Preemptive")
                sort_by = "priority";
            else
                sort_by = "arrival_time";


        foreach (var i in tasks_map)
        {
            i.Value.Sort();
        }
    }
    private void run_task_non_pre(task running)
    {
            if (running.arrival_time > Timer)
                Timer = running.arrival_time;
            running.start_time = Timer;
           
            bool fi_task_gya_w_enta_48al = false;
             
            do//lw fi task gya w enta 43'al
            {
                if (tasks_map.Count != 0)
                {
                    if (Timer + running.duration >= tasks_map.First().Key)
                    {
                        fi_task_gya_w_enta_48al = true;
                        update_current_tasks();
                    }
                    else
                        fi_task_gya_w_enta_48al = false;
                }
                else
                    break;
            } while (fi_task_gya_w_enta_48al);
            
        Timer += running.duration;
        running.finish_time = Timer;
        running.finished = true;
            task temp = new task(running);
        finished_tasks.Add(temp);
    }
    private void update_current_tasks()
    {
        float First_key = tasks_map.Keys.First();
        current_tasks.AddRange(tasks_map[First_key]);//append the map List to current_tasks List
        if (mode == "SJF-Preemptive"|| mode == "SJF")
            sort_by = "remaining_time";
        else
            sort_by = "priority";
       
        current_tasks.Sort();
        tasks_map.Remove(First_key);
    }
    private void preempt()
    {
            bool eli_geh_ahm = false;
            bool fi_task_gya_w_hya_48ala = true;
            // for(int i=0;i<tasks_map.Count;i++)
            while (fi_task_gya_w_hya_48ala)
            {
                if (tasks_map.Count != 0)
                {
                    if (mode == "SJF-Preemptive")
                    {
                        if (tasks_map.First().Value.First().remaining_time < (running_task.remaining_time - tasks_map.First().Key))
                            eli_geh_ahm = true;
                    }
                    else// (mode == "Priority-Preemptive")
                    {
                        if (tasks_map.First().Value.First().priority < running_task.priority)
                            eli_geh_ahm = true;
                    }

                    if (eli_geh_ahm)//lw eli geh 2at3
                    {
                        eli_geh_ahm = false;
                        float First_key = tasks_map.Keys.First();
                        running_task.start_time = Timer;
                        Timer = First_key;//running the current task till the new one come
                        running_task.finish_time = Timer;
                        running_task.remaining_time = running_task.remaining_time - (Timer - running_task.start_time);//set remaining time

                        if (running_task.remaining_time == 0)//lw 5lst matrg3ha4 le el current_tasks
                        {
                            running_task.finished = true;
                            task Temp = new task(running_task);
                            finished_tasks.Add(Temp);
                        }
                        else
                        {
                            task temp2 = new task(running_task);
                            current_tasks.Add(temp2);
                            task Temp = new task(running_task);
                            finished_tasks.Add(Temp);
                        }
                        update_current_tasks();
                        return;
                    }
                    else//lw eli geh ma2t34
                    {
                        //eli_geh_ma2t34 = true;
                        update_current_tasks();
                        if (tasks_map.Count != 0)
                        {
                            if (Timer + running_task.remaining_time < tasks_map.First().Key)
                                fi_task_gya_w_hya_48ala = false;
                        }
                        else
                            fi_task_gya_w_hya_48ala = false;

                        running_task.start_time = Timer;
                    }
                }
                else
                    break;//ya3ni mafi4 7aga gya tani w enta 43'al
            }
            //kda yeb2a el task 5lst w mfi4 7aga gat aham
            running_task.start_time = Timer;
            Timer = Timer + running_task.remaining_time;
            running_task.finish_time = Timer;
            running_task.finished = true;
            running_task.remaining_time = 0;
            task temp = new task(running_task);
                finished_tasks.Add(temp);  
    }
    private void run_preemptive()
    {
            if (running_task.arrival_time > Timer)
                Timer = running_task.arrival_time;

            running_task.start_time = Timer;
            if (tasks_map.Count != 0)
            {
                running_task.start_time = Timer;

                if (tasks_map.First().Key <= (Timer + running_task.remaining_time))//lw fi task gya w hya 43'ala
                    preempt();
                else
                {
                    running_task.start_time = Timer;
                    Timer = Timer + running_task.remaining_time;
                    running_task.finish_time = Timer;
                    running_task.finished = true;
                    task temp = new task(running_task);
                    finished_tasks.Add(temp);
                }
            }

            else//ya3ni mafi4 7ad hyege gded 4a3'al eli 3ndk beltartib bta3k
            {

                Timer = Timer + running_task.remaining_time;
                running_task.finish_time = Timer;
                running_task.finished = true;
                task temp = new task(running_task);
                finished_tasks.Add(temp);
            }
    }
    private void run_round()
    {
            running_task.start_time = Timer;
            if ((running_task.remaining_time - burst) <= 0)//
            {
                if (running_task.arrival_time > Timer)
                    Timer = running_task.arrival_time;
                running_task.start_time = Timer;
                Timer = Timer + running_task.remaining_time;
                running_task.finish_time = Timer;
                running_task.finished = true;
                task temp = new task(running_task);
                finished_tasks.Add(temp);
                if (tasks_map.Count != 0)
                {
                    if (Timer > tasks_map.First().Key)
                        update_queue();
                }

            }
            else
            {
                if (running_task.arrival_time > Timer)
                    Timer = running_task.arrival_time;
                running_task.start_time = Timer;
                Timer = Timer + burst;
                running_task.remaining_time = running_task.remaining_time - burst;
                running_task.finish_time = Timer;
                task temp = new task(running_task);
                task temp2= new task(running_task);
                finished_tasks.Add(temp);
               
                if (tasks_map.Count != 0)
                {
                    if (Timer > tasks_map.First().Key)
                        update_queue();
                }
                round_robin_queue.Enqueue(temp2);
            }
    }
    public void update_queue()
        {
            if (tasks_map.Count != 0)
            {
                float First_key = tasks_map.Keys.First();
                for (int i = 0; i < tasks_map[First_key].Count; i++)
                {
                    round_robin_queue.Enqueue(tasks_map[First_key][i]); 
                }

                tasks_map.Remove(First_key);
            }
        }
    public void ave_wating_time()
        {
            foreach(task t in finished_tasks)
            {
                if(t.finished)
                {
                    Ave_wating_time += (t.finish_time  - t.arrival_time - t.duration);
                }

            }
            Ave_wating_time = Ave_wating_time / tasks.Count;
        }
    public void schedul()
    {
       no_tasks = tasks.Count;
       if (mode == "FCFS")
       {
            sort_by = "arrival_time";//so Sort function will sort according the arrival time 
            tasks.Sort();
           
                foreach (task t in tasks)
                {
                    if (t.arrival_time > Timer)
                        Timer = t.arrival_time;
                    t.start_time = Timer;
                    Timer += t.duration;
                    t.finish_time = Timer;
                    t.finished = true;
                    finished_tasks.Add(t);
                }
        }
       if (mode == "SJF")
        {
            fill_tasks_map();
            float First_key = tasks_map.Keys.First();
                // current_tasks = tasks_map[First_key];
                //tasks_map.Remove(First_key);
                update_current_tasks();
                if (tasks_map.Count != 0)
            First_key = tasks_map.Keys.First();
            while (current_tasks.Count != 0)
            {
                    if (tasks_map.Count != 0)
                        First_key = tasks_map.Keys.First();

                    running_task = current_tasks.First();
                    current_tasks.RemoveAt(0);
                    run_task_non_pre(running_task);
                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_current_tasks();
                    }
                }
            }
       if (mode == "Priority")
       {
                fill_tasks_map();
                float First_key = tasks_map.Keys.First();
                // current_tasks = tasks_map[First_key];  
                //tasks_map.Remove(First_key);
               // mode = "SJF";
                update_current_tasks();
                mode = "Priority";
                while (current_tasks.Count != 0)
                {
                    if (tasks_map.Count != 0)
                        First_key = tasks_map.Keys.First();
                    running_task = current_tasks.First();
                    current_tasks.RemoveAt(0);
                    run_task_non_pre(running_task);//run the running task
                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_current_tasks();
                    }
                }
            }
       if (mode == "SJF-Preemptive")
          {
                fill_tasks_map();
                float First_key = tasks_map.Keys.First();
                //  current_tasks = tasks_map[First_key];
                //  tasks_map.Remove(First_key);
                update_current_tasks();

                if (tasks_map.Count != 0)
                    First_key = tasks_map.Keys.First();
                while (current_tasks.Count != 0)
                {
                    running_task = current_tasks.First();
                    current_tasks.RemoveAt(0);
                    run_preemptive();//run the running task
                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_current_tasks();
                    }
                }
            }
       if (mode == "Priority-Preemptive")
        {
            fill_tasks_map();
            float First_key = tasks_map.Keys.First();
                // current_tasks = tasks_map[First_key];
                // tasks_map.Remove(First_key);
                update_current_tasks();

                if (tasks_map.Count != 0)
                    First_key = tasks_map.Keys.First();
                while (current_tasks.Count != 0)
            {
                running_task = current_tasks.First();
                current_tasks.RemoveAt(0);
                run_preemptive();//run the running task

                    if ((current_tasks.Count == 0) && (tasks_map.Count != 0)) //|| ((tasks_map.Count != 0) && Timer + current_tasks.First().duration > First_key))
                    {
                        update_current_tasks();
                    }
                }
        }
       if (mode == "Round_Robin")
            {
                fill_tasks_map();
                update_queue();

                while (round_robin_queue.Count != 0)
                {
                    running_task = round_robin_queue.Dequeue();
                    run_round();
                    if ((round_robin_queue.Count == 0) && (tasks_map.Count != 0))
                    {
                        update_queue();
                    }
                }
                
            }
            
    }

}
