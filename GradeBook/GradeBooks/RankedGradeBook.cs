using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class RankedGradeBook : BaseGradeBook
    {
        RankedGradeBook (string name): base(name)
        {
            base.Type = Enums.GradeBookType.Ranked;
        }
    }
}
