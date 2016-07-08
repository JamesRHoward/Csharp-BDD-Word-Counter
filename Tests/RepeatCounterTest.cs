using System;
using System.Collections.Generic;
using Xunit;
using RepeatCounter.Objects;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_dogdog()
    {
      int counterResult = 1;
      RepeatCounter testCounter = new RepeatCounter();
      int result = testCounter.CountRepeats("dog","dog");
      Assert.Equal(counterResult, result);
    }
  }
}
