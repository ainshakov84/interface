using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интерфесй_домашнее_задание
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue; ;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int S)
        {
            step = S;
        }
    }
        class MathProgression : ISeries
        {
            int step;
            int startValue;
            int currentValue;
            public int getNext()
            {
                currentValue *= step;
                return currentValue;
            }

            public void reset()
            {
                currentValue = startValue; ;
            }

            public void setStart(int x)
            {
                startValue = x;
                currentValue = startValue;
            }
            public void setStep(int S)
            {
                step = S;
            }
        }
    }


