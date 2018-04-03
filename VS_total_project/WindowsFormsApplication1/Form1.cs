using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WinForm : Form
    {
        
        schedular sc =new schedular();
        DataTable dt = new DataTable();
        
        public WinForm()
        {
            InitializeComponent();
            GNtt_chart1.Visible = false;
            Name_lable.Visible = false;
            Nametx.Visible = false;
            priority_label.Visible = false;
            prioritytx.Visible = false;
            RRBtx.Visible = false;
            RR_label.Visible = false;
            arrivaltx.Visible = false;
            Arrival_label.Visible = false;
            dutx.Visible = false;
            Duration_label.Visible = false;
            Run_but.Visible = false;
            insert_task_but.Visible = false;
            Gntt_chart_but.Visible = false;
            clear_data_but.Visible = false;
            label1.Visible = false; 
            //GNtt_chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
           // GNtt_chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
           // GNtt_chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            //GNtt_chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
        }


        private void button1_Click(object sender, EventArgs e)//insr=ert_task
        {
            float arrival_time=0;
            int priority=0;
            float duration=0; 
            float RRBTX=0;
            string name = "";
          
          
            dataGridView1.Visible = true;

            
                if(String.IsNullOrEmpty(Nametx.Text))
                     Nametx.Text = "task" + (sc.tasks.Count + 1);
                else
                    name=Nametx.Text ;

            if (String.IsNullOrEmpty(arrivaltx.Text)) 
                arrival_time = 0;
            else
                arrival_time = Convert.ToSingle(arrivaltx.Text);
      

            if (String.IsNullOrEmpty(prioritytx.Text))
                priority = 0;
            else
                priority = Convert.ToInt32(prioritytx.Text);

            if (String.IsNullOrEmpty(dutx.Text))
                duration = 0;
            else
                duration = Convert.ToSingle(dutx.Text);

            if (String.IsNullOrEmpty(RRBtx.Text))
            {
                if (sc.mode == "Round_Robin")
                {
                    RRBTX = sc.burst;
                }
                else
                    RRBTX = 0;
            }
            else
            {
                RRBTX = Convert.ToSingle(RRBtx.Text);
                sc.burst = RRBTX;
            }
            dt.Rows.Add(Nametx.Text, arrival_time, priority, duration, RRBTX);
            this.dataGridView1.DataSource = dt;
            task t = new task(duration, arrival_time, priority, Nametx.Text);
            sc.tasks.Add(t);
            sc.no_tasks++;
            Nametx.Clear();
            arrivaltx.Clear();
            dutx.Clear();
            RRBtx.Clear();
            prioritytx.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dt.Columns.AddRange(new DataColumn[5]
            {
                new DataColumn("Name",typeof(string)),
                new DataColumn("Arrival",typeof(float)),
                new DataColumn("Priority",typeof(int)),
                new DataColumn("Duration",typeof(float)),
                new DataColumn("Quantum",typeof(float)),
            });
                
                
                
                }

        private void button2_Click(object sender, EventArgs e)//Clear button
        {

            if (MessageBox.Show("Are you sure thar will clear all saved tasks", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GNtt_chart1.Visible = false;
                Name_lable.Visible = false;
                Nametx.Visible = false;
                priority_label.Visible = false;
                prioritytx.Visible = false;
                RRBtx.Visible = false;
                RR_label.Visible = false;
                arrivaltx.Visible = false;
                Arrival_label.Visible = false;
                dutx.Visible = false;
                Duration_label.Visible = false;
                Run_but.Visible = false;
                insert_task_but.Visible = false;
                Gntt_chart_but.Visible = false;
                clear_data_but.Visible = false;
                label1.Visible = false;
                sc.tasks.Clear();
                sc.finished_tasks.Clear();
                


                Application.Restart();
            }
          

        }

        private void Run_Click(object sender, EventArgs e)
        {
            // dataGridView1.Visible = false;
            
            if (sc.tasks.Count == 0)
                MessageBox.Show("there is no entered tasks");
            else
            {
                sc.schedul();
                sc.ave_wating_time();
                string s = "Ave Wating Time=" + sc.Ave_wating_time;
                label1.Text = s;
                label1.Visible = true;
                Gntt_chart_but.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Name_lable.Visible = true;
            Nametx.Visible = true;
            Run_but.Visible = true;
            insert_task_but.Visible = true;
            clear_data_but.Visible = true;
            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("FCFS"))
            {
                sc.mode = "FCFS";
                priority_label.Visible = false;
                prioritytx.Visible = false;
                RRBtx.Visible = false;
                RR_label.Visible = false;
                arrivaltx.Visible = true;
                Arrival_label.Visible = true;
                dutx.Visible = true;
                Duration_label.Visible = true;


            }
            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("SJF(Non Preemptive)"))
            {
                sc.mode = "SJF";
                priority_label.Visible = false;
                prioritytx.Visible = false;
                RRBtx.Visible = false;
                RR_label.Visible = false;
                arrivaltx.Visible = true;
                Arrival_label.Visible = true;
                dutx.Visible = true;
                Duration_label.Visible = true;

            }
            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("SJF(Preemptive)"))
            {
                sc.mode = "SJF-Preemptive";
                priority_label.Visible = false;
                prioritytx.Visible = false;
                RRBtx.Visible = false;
                RR_label.Visible = false;
                arrivaltx.Visible = true;
                Arrival_label.Visible = true;
                dutx.Visible = true;
                Duration_label.Visible = true;
            }
            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("Priority(Non Preemptive)"))
            {
                sc.mode = "Priority";
                priority_label.Visible = true;
                prioritytx.Visible = true;
                RRBtx.Visible = false;
                RR_label.Visible = false;
                arrivaltx.Visible = true;
                Arrival_label.Visible = true;
                dutx.Visible = true;
                Duration_label.Visible = true;
            }
            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("Priority(Preemptive)"))
            {
                sc.mode = "Priority-Preemptive";
                priority_label.Visible = true;
                prioritytx.Visible = true;
                RRBtx.Visible = false;
                RR_label.Visible = false;
                arrivaltx.Visible = true;
                Arrival_label.Visible = true;
                dutx.Visible = true;
                Duration_label.Visible = true;
            }
            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("Round Robin"))
            {
                sc.mode = "Round_Robin";
                priority_label.Visible = false;
                prioritytx.Visible = false;
                RRBtx.Visible = true;
                RR_label.Visible = true;
                arrivaltx.Visible = true;
                Arrival_label.Visible = true;
                dutx.Visible = true;
                Duration_label.Visible = true;
            }

        }

        private void GNtt_chart1_Click(object sender, EventArgs e)
        {
            GNtt_chart1.Visible = false;
            GNtt_chart1.Series["Tasks"].Points.Clear();
            sc.Timer = 0;
            dataGridView1.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            comboBox1.Visible = true;
            Name_lable.Visible = true;
            Nametx.Visible = true;
            priority_label.Visible = true;
            prioritytx.Visible = true;
            RRBtx.Visible = true;
            RR_label.Visible = true;
            arrivaltx.Visible = true;
            Arrival_label.Visible = true;
            dutx.Visible = true;
            Duration_label.Visible = true;
            Run_but.Visible = true;
            Run_but.Visible = true;
            insert_task_but.Visible = true;
            Gntt_chart_but.Visible = true;
            clear_data_but.Visible = true;
            //ve_wait.Visible = true;
            label1.Visible = true;
            sc.finished_tasks.Clear();
           
            
        }

        private void Gntt_chart_Click(object sender, EventArgs e)
        {
            if (sc.finished_tasks.Count != 0 && sc.tasks.Count != 0)
            {
                for (int i = 0; i < sc.finished_tasks.Count; i++)
                {
                    GNtt_chart1.Series["Tasks"].Points.AddXY(sc.finished_tasks[i].name, sc.finished_tasks[i].start_time, sc.finished_tasks[i].finish_time);
                    GNtt_chart1.Series["Tasks"].Points[i].Label = Convert.ToString(sc.finished_tasks[i].name);
                    //   GNtt_chart1.Series["Tasks"].Points.AddXY(sc.finished_tasks[i].name, ((i == 0) ? 0 : sc.finished_tasks[i - 1].finish_time), sc.finished_tasks[i].finish_time);
                }
                dataGridView1.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                comboBox1.Visible = false;
                Run_but.Visible = false;
                insert_task_but.Visible = false;
                Gntt_chart_but.Visible = false;
                clear_data_but.Visible = false;
                label1.Visible = false;
                Name_lable.Visible = false;
                Nametx.Visible = false;
                priority_label.Visible = false;
                prioritytx.Visible = false;
                RRBtx.Visible = false;
                RR_label.Visible = false;
                arrivaltx.Visible = false;
                Arrival_label.Visible = false;
                dutx.Visible = false;
                Duration_label.Visible = false;
                Run_but.Visible = false;

                GNtt_chart1.Visible = true;
                MessageBox.Show("Click on the chart to hide it");
            }
            else
            {
                if (sc.tasks.Count == 0)
                    MessageBox.Show("there is no entered tasks");
                else
                    MessageBox.Show("Run your Tasks First");
            }

            }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    class task : IComparable<task>
    {
        public float duration, arrival_time, remaining_time, finish_time,start_time;

        public int priority;
        public bool finished;

        public string name;
        
        public task(float duration = 0, float arrival_time = 0, int priority = 0, string name = "noname")
        {
            this.arrival_time = arrival_time;
            this.duration = duration;
            this.name = name;
            this.priority = priority;
            this.remaining_time = duration;
            this.finished = false;
            start_time = arrival_time;
        }
        public task(task t)
        {
            this.arrival_time = t.arrival_time;
            this.duration = t.duration;
            this.name = t.name;
            this.priority = t.priority;
            this.remaining_time = t.remaining_time;
            this.finished = t.finished;
            this.finish_time = t.finish_time;
            this.start_time = t.start_time;
        }
        static public task fill_task(string name, int priority, float arrival_time, float duration)
        {
            task t=new task();
            t.name = name;
            t.priority = priority;
            t.arrival_time = arrival_time;
            t.duration = duration;
            return t;

        }
        public int CompareTo(task other)
        {
            if (schedular.sort_by == "remaining_time")
            {
                if (this.remaining_time > other.remaining_time)
                    return 1;
                else if (this.remaining_time == other.remaining_time)
                {
                    if (this.arrival_time > other.arrival_time)
                    {
                        return 1;
                    }
                    else
                        return -1;
                }
                else
                    return -1;
            }
            else if (schedular.sort_by == "priority")
            {
                if (this.priority > other.priority)
                    return 1;

                else if (this.priority == other.priority)
                {
                    if (this.arrival_time > other.arrival_time)
                    {
                        return 1;
                    }
                    else
                        return -1;
                }
                else
                    return -1;
            }
            else if (schedular.sort_by == "arrival_time")
            {

                if (this.arrival_time > other.arrival_time)
                {
                    return 1;
                }
                else
                    return -1;
            }
            else
                return 1;
        }


    }

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

}
