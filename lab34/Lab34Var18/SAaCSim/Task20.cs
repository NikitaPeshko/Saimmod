using System;
using System.Collections.Generic;
using System.Linq;

namespace SAaCSim
{
    class Task20
    {
        private readonly double ρ;
        private readonly double π1;
        private readonly double π2;
        private readonly int ticks;
        private List<String> currentState=new List<string>();


        private readonly Dictionary<string, byte> SystemStates = new Dictionary<string, byte>
        {
            ["000"] = 0,
            ["100"] = 1,
            ["001"] = 2,
            ["101"] = 3,
            ["011"] = 4,
            ["111"] = 5,
            ["021"] = 6,
            ["121"] = 7,
            ["221"] = 8,
           


        }; 

        private Request π1CurrentTick;
        private Request π2CurrentTick;
        private List<Request> qCurrentTick;

        private Request π1NextTick;
        private Request π2NextTick;
        private List<Request> qNextTick;

        private const Request Empty = null;
        

        private List<Request> requests;

        private Random random;

        private int[] P;

        public Task20(double ρ, double π1, double π2, int ticks = 10000)
        {
            this.ρ = ρ;
            this.π1 = π1;
            this.π2 = π2;
            this.ticks = ticks;
        }

        public void Execute()
        {
            random = new Random();
            requests = new List<Request>();

            π1CurrentTick = Empty;
            π2CurrentTick = Empty;
            qCurrentTick = new List<Request>();
            qCurrentTick.Add(Empty);
            qCurrentTick.Add(Empty);

            

            P = new int[9];
            
            Run();
            Display();
        }

        private void Display()
        {
            double numberOfComplitedRequest=(double)requests.Count(x => x.State == RequestState.Completed);
            double numberOfDiscardedRequest = (double)requests.Count(x => x.State == RequestState.Discarded);
            
            double A = requests.Count(x => x.State == RequestState.Completed) / (double)ticks;
            double Potc = requests.Count(x => x.State == RequestState.Discarded) / (double)requests.Count;
            double pbl = currentState.Count(x => x == "221") / (double)ticks;
            double q = requests.Count(x => x.State == RequestState.Completed) / (double)requests.Count;
            double Loch = (P[4] + P[5] + 2 * (P[6] + P[7] + P[8])) / (double)ticks;
            double Lc = (P[1] + P[2] + 2 * (P[3] + P[4]) + 3 * (P[5] + P[6]) + 4 * (P[7] + P[8])) / (double)ticks;
            double Woch = (P[4] + P[5] + 2 * (P[6] + P[7] + P[8])) / (double)requests.Count(x => x.State == RequestState.Completed);
            double Wc = (P[1] + P[2] + 2 * (P[3] + P[4]) + 3 * (P[5] + P[6]) + 4 * (P[7] + P[8])) / numberOfComplitedRequest;
            double k1 = (P[1] + P[3] + P[5] + P[7] + P[8]) / (double)ticks;
            double k2 = (P[2] + P[4] + P[5] + P[6] + P[7]) / (double)ticks;




            Console.WriteLine("---------------");

            Console.WriteLine("P1 - 000: {0:0.0000}", P[0] / (double) ticks);
            Console.WriteLine("P2 - 100: {0:0.0000}", P[1] / (double) ticks);
            Console.WriteLine("P3 - 001: {0:0.0000}", P[2] / (double) ticks);
            Console.WriteLine("P4 - 101: {0:0.0000}", P[3] / (double) ticks);
            Console.WriteLine("P5 - 011: {0:0.0000}", P[4] / (double) ticks);
            Console.WriteLine("P6 - 111: {0:0.0000}", P[5] / (double) ticks);
            Console.WriteLine("P7 - 021: {0:0.0000}", P[6] / (double) ticks);
            Console.WriteLine("P8 - 121: {0:0.0000}", P[7] / (double)ticks);
            Console.WriteLine("P9 - 221: {0:0.0000}", P[8] / (double)ticks);
            
           

            Console.WriteLine("---------------");

            Console.WriteLine("A:     {0:0.000}", A);
            Console.WriteLine("Pотк:  {0:0.000}", Potc);
            //Console.WriteLine("Ws:  {0:0.000}", requests.Sum(x => x.ExistingTime) / (double)requests.Count(x => x.State != RequestState.Discarded));
            Console.WriteLine("Pbl:  {0:0.0000}",pbl);
            Console.WriteLine("Q:     {0:0.000}", 1-Potc);
            Console.WriteLine("Loch:     {0:0.000}", Loch);
            Console.WriteLine("Lc:     {0:0.000}", Lc);
            Console.WriteLine("Woch:     {0:0.000}", Woch);
            Console.WriteLine("Wc:     {0:0.000}", Wc);
            Console.WriteLine("K1:     {0:0.000}", k1);
            Console.WriteLine("K2:     {0:0.000}", k2);
            Console.WriteLine("Q:     {0:0.000}", q);
        }

        private void Run()
        {
            for (int i = 0; i < ticks - 1; ++i)
            {
                π1CurrentTick = π1NextTick;
                π2CurrentTick = π2NextTick;
                qCurrentTick = qNextTick;

                π1NextTick = Empty;
                π2NextTick = Empty;
                qNextTick = new List<Request>();
                qNextTick.Add(Empty);
                qNextTick.Add(Empty);

                CalculateP();

                Process_π2();
                Process_Queue();
                Process_π1();
                Process_ρ(i);

                requests.ForEach(x => x.TicksPassed());
            }
        }

        private void CalculateP()
        {

            string CurrentState = π1CurrentTick == null ? "0" : ((int) π1CurrentTick.State).ToString();
            if (qCurrentTick == null)
            {
                CurrentState += "0";
            }
            else if (qCurrentTick[0].State == RequestState.Processing)
            {
                CurrentState += "1";
            }
            else if (qCurrentTick[0].State == RequestState.DoubleProssesing)
            {
                CurrentState += "2";
            }

            CurrentState += π2CurrentTick == null ? "0" : ((int)π2CurrentTick.State).ToString();
            
            currentState.Add(CurrentState);

            P[SystemStates[CurrentState]]++;
        }

        private void Process_π2()
        {
            if (π2CurrentTick == Empty)
            {
                π2NextTick = Empty;
            }
            else if (π2CurrentTick.State == RequestState.Processing)
            {
                if (random.NextDouble() < π2)
                {
                    π2NextTick = π2CurrentTick;
                }
                else
                {
                    π2CurrentTick.State = RequestState.Completed;
                    π2NextTick = Empty;
                }
            }
        }

        private void Process_Queue()
        {
            qCurrentTick[0] = Empty;
            if (qCurrentTick[0] == Empty)
            {
                qNextTick[0] = Empty;
            }
            else if (qCurrentTick[0].State == RequestState.Processing)
            {
                if (π2NextTick == Empty)
                {
                    π2NextTick = qCurrentTick[0];
                    qNextTick[0] = qNextTick[1];
                    qNextTick[1] = Empty;
                }
                else if (π2CurrentTick.State == RequestState.Processing)
                {
                    qNextTick = qCurrentTick;
                }
            }
            else if (qCurrentTick[0].State == RequestState.DoubleProssesing)
            {
                if (π2NextTick == Empty)
                {
                    π2NextTick = qCurrentTick[0];
                    qNextTick[0] = qNextTick[1];
                    qNextTick[1] = Empty;

                    qCurrentTick[0].State = RequestState.Processing;
                }
                else if (π2CurrentTick.State == RequestState.Processing)
                {
                    qNextTick = qCurrentTick;
                    //qCurrentTick.State = RequestState.DoubleProssesing;
                }
            }
        }

        private void Process_π1()
        {
            if (π1CurrentTick == Empty)
            {
                π1NextTick = Empty;
            }
            else if (π1CurrentTick.State == RequestState.Processing)
            {
                if (random.NextDouble() < π1)
                {
                    π1NextTick = π1CurrentTick;
                }
                else
                {
                    if (qNextTick[0] == Empty)
                    {
                        if (π2NextTick == Empty)
                        {
                            π2NextTick = π1CurrentTick;
                            π1CurrentTick = Empty;
                        }
                        else
                        {
                            qNextTick[0] = π1CurrentTick;
                            π1NextTick = Empty;
                        }
                    }
                    else if (qNextTick[0].State == RequestState.DoubleProssesing)
                    {
                        π1CurrentTick.State = RequestState.Pending;
                        π1NextTick = π1CurrentTick;
                        
                    }
                    else if (qNextTick[0].State == RequestState.Processing)
                    {
                        qNextTick[0] = π1CurrentTick;
                        π1NextTick = Empty;
                        qNextTick[0].State = RequestState.DoubleProssesing;
                    }
                }
            }
            else if (π1CurrentTick.State == RequestState.Pending)
            {
                if (qNextTick[0] == Empty)
                {
                    π1CurrentTick.State = RequestState.Processing;
                    qNextTick[1] = π1CurrentTick;
                    π1NextTick = Empty;
                }
                else if (qNextTick[0].State == RequestState.DoubleProssesing)
                {
                    π1CurrentTick.State = RequestState.Pending;
                    π1NextTick = π1CurrentTick;
                }
            }
        }

        private void Process_ρ(int i)
        {
            if (random.NextDouble() >= ρ)
            {
                if (π1NextTick?.State == RequestState.Processing || π1NextTick?.State == RequestState.Pending)
                {
                    requests.Add(new Request { ExistingTime = 0, CreationTact = i, State = RequestState.Discarded });
                }
                else
                {
                    π1NextTick = new Request { ExistingTime = 0, CreationTact = i, State = RequestState.Processing };
                    requests.Add(π1NextTick);
                }
            }
        }
    }
}

