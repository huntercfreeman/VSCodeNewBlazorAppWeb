function postToParent() {
    window.parent.postMessage("hello there!", "*");
}