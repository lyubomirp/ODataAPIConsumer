"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var LoaderService = /** @class */ (function () {
    function LoaderService() {
        this.loader = document.getElementsByClassName('loader-container')[0];
    }
    LoaderService.prototype.showLoader = function () {
        this.loader.classList.remove('hidden');
    };
    LoaderService.prototype.hideLoader = function () {
        this.loader.classList.add('hidden');
    };
    return LoaderService;
}());
exports.LoaderService = LoaderService;
//# sourceMappingURL=loader.service.js.map