using System;
using System.Collections;
using System.Collections.Generic;

public class ResponseList
{
  public IEnumerable list { get; set; }
  public int page { get; set; }
  public int pages { get; set; }
}