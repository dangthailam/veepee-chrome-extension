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
    const article = this.closest('article.sales__sc-156l7nn-0');
    const product = article.querySelector('header .sales__sc-156l7nn-5 a');
    const productDetailUrl = product.href;
    const productName = product.textContent;
    let productOriginalPrice = article.querySelector('header .sc-ejmJqG').textContent;
    let productFinalPrice = article.querySelector('header .sc-ibKkBv').textContent;
    const productSalesPercent = article.querySelector('header .sc-hYQoXb').textContent;
    const currency = productFinalPrice.split(' ')[1];
    productOriginalPrice = Number(productOriginalPrice.split(' ')[0].replace(',', '.'));
    productFinalPrice = Number(productFinalPrice.split(' ')[0].replace(',', '.'));
    console.log(productDetailUrl);
    console.log(productName);
    console.log(productOriginalPrice);
    console.log(productFinalPrice);
    console.log(productSalesPercent);
    console.log(currency);

}


