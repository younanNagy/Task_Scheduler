   

      ////////////////////////////////////////////////////////////////////////////////////
     //do not construct a task manually use fill_task function or the first constructor//
    ////////////////////////////////////////////////////////////////////////////////////

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
