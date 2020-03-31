class Program
    {
        static void Main(string[] args)
        {
            Triangle tri1= new Triangle();
            //SetSize and OutputSize are for when the user implements the triangles details and the output is the calculations return value
            tri1.SetSize();
            tri1.OutputSize();

            Console.Readline();
        }
        //declaring the objects and there data types; Lenght, Height, Area and Perimeter
        public class Triangle
        {
            private int _triLength;
            private int _triHeight;
            private int _triArea;
            private int _triPerimeter;

            public int TriLength 
            {
                get { return _triLength; }
            }

            public int TriHeight 
            {
                get { return _triHeight; }
            }

            public int TriArea 
            {
                get { return _triArea; }
            }

            public int TriPerimeter 
            {
                get { return _triPerimeter; }
            }

            public void SetSize()
            {
                //Creating the output of the program to the user below
                Console.Writeline("What is the Length of one of the sides of the triangle?");
                _triLength = Int32.Parse(Console.Readline());
                Console.Writeline("What is the Height of the triangle?");
                _triHeight = Int32.Parse(Console.Readline());
            }

            public void CalculateSize()
            {
                //this void calculates the area and perimeter using simple mathematical expressions
                _triArea = (_triLength * _triHeight) / 2;
                _triPerimeter = 3 * _triLength;
            }

            public void OutputSize()
            {
                //Data created inside the object by the program after initial input is then given back after calculations
                CalculateSize();
                Console.Writeline($"The area of the triangle is {_triArea}.");
                Console.Writeline($"The Perimeter is {_triPerimeter}.");
                Console.Readline()
            }
        }
    }