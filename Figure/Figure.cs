using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figure
{
    enum Status { Invisible, Visible }
    abstract class Figure
    {
        
        Color Color;
        Status Visibility;
        public Figure()
        {
            Color = Color.White;
            Visibility = Status.Invisible;
        }
        public Figure(Color color, Status status)
        {
            Color = color;
            Visibility = status;
        }
        public void MoveVert()
        {
            Console.WriteLine("Vertikalno dvij");
        }
        public void MoveHoriz()
        {
            Console.WriteLine("Horizantal dvij");
        }
        public void ChangeColor(Color dColor)
        {
            Color = dColor;
        }
        public void ChangeStatus()
        {

            if (Visibility.Equals(Status.Visible))
            {
                Visibility--;
            }
            else
            {
                Visibility++;
            }
        }
        public void Show()
        {
            Console.WriteLine($"Цвет — {Color}\nСостояние — {Visibility}");
        }
    }
}
