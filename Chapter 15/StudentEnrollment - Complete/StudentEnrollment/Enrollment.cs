﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    record Enrollment(int StudentID, string CourseName, DateOnly DateEnrolled);
}
