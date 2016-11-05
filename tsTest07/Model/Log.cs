using System;
using TypeLite;

namespace tsTest07.Model
{
    [TsClass]
    public class Log
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedAT { get; set; }
    }
}