function findAndAttachExportButtons() {
    let expressBuyButton = document.querySelector(".sc-gEOWYS.icEKYX");

    if (!expressBuyButton) return;
    expressBuyButton.classList.add('jPGME');

    let flexDiv = document.createElement("div");
    flexDiv.classList.add("export-container");

    let exportButton = document.createElement("button");
    exportButton.innerText = "Export";
    exportButton.classList.add('icEKYX');
    exportButton.classList.add('exportButton');
    exportButton.addEventListener("click", exportArticle)

    flexDiv.appendChild(exportButton);

    expressBuyButton.parentElement.appendChild(exportButton);
}


function exportArticle() {
    const productPhotoUrls = Array.from(document.querySelectorAll('ul.sales__sc-1qfvzvq-0 li img')).map(p => p.src);

    const productName = document.querySelector('#__next > div > div.sc-iEhLsB.lcrbzR > div > div > section > div:nth-child(2) > div > div.sc-lcLUZz.gjNHRU').textContent;
    let productFinalPrice = document.querySelector('#__next > div > div.sc-iEhLsB.lcrbzR > div > div > section > div:nth-child(2) > div > div.sc-bbUAki.cjlFQF > div > div.sc-krduYZ.gopsDW > div > span.sc-ksHpcM.kGavuF.sc-fvOMhg.sc-ibKkBv.bbwsQi.bfVmUi').textContent;
    let productOriginalPrice = document.querySelector('#__next > div > div.sc-iEhLsB.lcrbzR > div > div > section > div:nth-child(2) > div > div.sc-bbUAki.cjlFQF > div > div.sc-krduYZ.gopsDW > div > span.sc-Dtwra.eRuwRt > span.sc-ksHpcM.hhexPA.sc-fvOMhg.sc-ejmJqG.bbwsQi.icELPl').textContent;
    const salePercentage = document.querySelector('#__next > div > div.sc-iEhLsB.lcrbzR > div > div > section > div:nth-child(2) > div > div.sc-bbUAki.cjlFQF > div > div.sc-krduYZ.gopsDW > span').textContent;
    
    const detailProductIframe = document.querySelector('iframe');
    const brandLogo = detailProductIframe.contentWindow.document.querySelector('div.ftBlocTitle > h3 > img').src;
    const brandName = document.title.split('|')[0].trim();
    productFinalPrice = Number(productFinalPrice.split(' ')[0].replace(',', '.'));
    productOriginalPrice = Number(productOriginalPrice.split(' ')[0].replace(',', '.'));

    console.log(productPhotoUrls, productName, productFinalPrice, productOriginalPrice, salePercentage, brandName, brandLogo);
}

findAndAttachExportButtons();