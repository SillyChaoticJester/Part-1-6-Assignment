using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_6_Assignment
{
    public class Die
    {
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        public Die(int roll)
        {
            _generator = new Random();
            if (roll < 1)
                _roll = 1;
            else if (roll > 6)
                _roll = 6;
            else
                _roll = roll;
        }

        public int Roll
        {
            get { return _roll; }
            //set { _roll = value; }

        }

        public override string ToString()
        {
            return _roll + "";
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }

        public void DrawDie()
        {
            if (_roll == 1)
            {
                Console.WriteLine("-----\r\n|   |\r\n| o |\r\n|   |\r\n-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----\r\n|o  |\r\n|   |\r\n|  o|\r\n-----");
            }
            else if (_roll == 3)
            {
                Console.WriteLine("-----\r\n|o  |\r\n| o |\r\n|  o|\r\n-----");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|   |\r\n|o o|\r\n-----\r\n");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----\r\n|o o|\r\n| o |\r\n|o o|\r\n-----\r\n");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|o o|\r\n|o o|\r\n-----");
            }
        }
    }
}
