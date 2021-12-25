using System;
using Bridge;

namespace ScreepsApi {
    [External]
    [Namespace(false)]
    [Name("console")]
    public static class Debug {
        [Template("console.log({value})")]
        public static extern void Log(string value);

        [Template("console.log(Bridge.Enum.toString({value:type}, {value}))")]
        public static extern void Log(Enum value);

        [Template("console.log(String.fromCharCode({value}))")]
        public static extern void Log(char value);

        [Template("console.log({value}.toString())")]
        public static extern void Log(Decimal value);

        [Template("console.log({value} && {value}.toString())")]
        public static extern void Log(Decimal? value);
    }
}