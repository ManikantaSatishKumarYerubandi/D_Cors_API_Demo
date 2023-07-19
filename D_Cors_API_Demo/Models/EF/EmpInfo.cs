using System;
using System.Collections.Generic;

namespace D_Cors_API_Demo.Models.EF;

public partial class EmpInfo
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesignation { get; set; }

    public int? EmpSalary { get; set; }
}
