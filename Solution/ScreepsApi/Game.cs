// ReSharper disable UnassignedField.Global
using Bridge;

namespace ScreepsApi {
    [External]
    [Namespace(false)]
    [Name("Game")]
    public static class Game {
        [Template("Game.time")] public static decimal Time;
    }
}