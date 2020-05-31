using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Work5.service.UI
{
    class ProductService
    {
        public static AllProductsPage CreateProduct(Products product, IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            AllProductsPage allProductsPage = homePage.AllProductView();
            CreateProductPage createProductPage = allProductsPage.createButtonClick();
            createProductPage = createProductPage.InputProduct(product);
            allProductsPage = createProductPage.ClickCreateButton();
            return new AllProductsPage(driver);
        }

    }
}

