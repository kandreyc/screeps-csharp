var bridge = require("bridge.min")
require("bridge.meta.min")
require("Screeps.min")

module.exports.loop = function () {
    console.log("start");
    bridge.ns("Screeps.GameLoop").Tick();
};
//# sourceMappingURL=main.js.map