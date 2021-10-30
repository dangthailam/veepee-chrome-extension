let expressBuyButtons = document.querySelectorAll(".fXwKDq");

expressBuyButtons.forEach(button => {
    let flexDiv = document.createElement("div");
    flexDiv.classList.add("export-container");

    let exportButton = document.createElement("button");
    exportButton.innerText = "Export";
    exportButton.classList.add('fXwKDq');
    exportButton.classList.add('exportButton');

    exportButton.addEventListener("click", exportArticle)

    flexDiv.appendChild(exportButton);

    button.parentElement.parentElement.appendChild(flexDiv);
});

function exportArticle() {
    console.log(this);
}


