using System;


namespace FItnessApp.BL.Model
{
    public class Gender
    {
        public string Name { get; }
        public Gender (String name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("")
            }
        }
    }
}
