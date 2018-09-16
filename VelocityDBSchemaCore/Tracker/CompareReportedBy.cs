﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VelocityDb.Session;
using VelocityDb.Collection.Comparer;

namespace VelocityDbSchema.Tracker
{
  class CompareReportedBy : VelocityDbComparer<Issue>
  {
    public CompareReportedBy() { }
    public override int Compare(Issue aIssue, Issue bIssue)
    {
      int compareValue = aIssue.ReportedBy.CompareTo(bIssue.ReportedBy);
      if (compareValue != 0)
        return compareValue;
      return base.Compare(aIssue, bIssue);
    }
  }
}
