using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Feeder.Opml
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOpmlBody : IOpmlOutlineProvider
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [CLSCompliant(false)]
    public class OpmlBody : OpmlOutlineProvider, IOpmlBody
    {
    }
}
