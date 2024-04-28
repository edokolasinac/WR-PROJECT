using System;
using System.ComponentModel.DataAnnotations;

public class Products
{
    private int _id;
    private string _productNumber;
    private string _productDescription;

    [Required(ErrorMessage = "Id is required")]
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    [Required(ErrorMessage = "Product number is required")]
    [StringLength(111, ErrorMessage = "Product number must be at most 20 characters long")]
    public string ProductNumber
    {
        get { return _productNumber; }
        set { _productNumber = value; }
    }

    [Required(ErrorMessage = "Product description is required")]
    [StringLength(100, ErrorMessage = "Product description must be at most 100 characters long")]
    public string ProductDescription
    {
        get { return _productDescription; }
        set { _productDescription = value; }
    }
}
