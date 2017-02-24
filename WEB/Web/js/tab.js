function Tab(pages) {
    this.pages = pages;
    this.curPage = 1;
    document.getElementById("iframeResult").src = pages[0];
}

Tab.prototype.setHoverLi = function(liId) {
    if (liId == this.curPage) return;
    for (var i = 1; i <= pages.length; i++) {
        document.getElementById("tb_" + i).className = (i == liId) ? "hovertab" : "normaltab";
    }
    document.getElementById("iframeResult").src = pages[liId - 1];
    this.curPage = liId;
}