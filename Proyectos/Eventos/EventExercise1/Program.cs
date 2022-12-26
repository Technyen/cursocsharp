using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var form = new Form();
            form.Interactuar();
        }
    }

    public class Button
    {
        public delegate void ButtonClickHandler();

        public event ButtonClickHandler ClickEvent;

        public void Click() 
        { 
            ClickEvent?.Invoke(); 
        } 

    }

    public class Form
    {
        Button mybutton;
        public Form()
        {
            mybutton = new Button();
            mybutton.ClickEvent += ClickHandler;
        }

        public void ClickHandler()
        {
            Console.WriteLine("The button was clicked");
           
        }

        public void Interactuar()
        {
            mybutton.Click();
        }
        
    }
}