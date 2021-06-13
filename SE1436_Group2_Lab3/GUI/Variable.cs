using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE1426_Group2_Lab3.GUI
{
    public class Variable
    {
        public static string username;
        public static int role;

        public static string Username { get => username; set => username = value; }
        public static int Role { get => role; set => role = value; }
    }
}
