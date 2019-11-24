using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandaradGradeBook : BaseGradeBook
    {
        public StandaradGradeBook(string name) :base(name)
        {
            Type = Enums.GradeBookType.Standarad;
        }
    }
}
