class Product {
    public string title;
    public string code;
    public string brand;
    public double price;
    
    Product(string title, string code, string brand, double price){
        this.title = title;
        this.code = code;
        this.brand = brand;
        this.price = price;
    }
}

class Invoice {
    Product product;
    int quantity;
    double discount;
    double tax;
    double total;

    public Invoice(Product product, int quantity, double discount, double tax, double total){
        this.product = product;
        this.quantity = quantity;
        this.discount = discount;
        this.tax = tax;
        this.total = total;
    }


    public double calculateTotal() {
        double price = ((product.price - product.price*discount) * this.quantity);
        double priceWithTaxes = price * (1 + this.tax);
        return priceWithTaxes;
    }

    /// kode diberi komentar di bawah ini adalah yang yang salah akan memasukkan semua fungsi kedalam satu kelas.
    /// seharusnya fungsi2 yang tidak sesuai dengan kelasnya, dibuat sesuai dengan kelasnya

    // public void printInvoice() {
    //     // print functions
    // }

    // public void saveToFile(string filename) {
    //     // save to file
    // }
}

//printing dipisah kelasnya
class InvoicePrinter {
    private Invoice invoice;
    
    InvoicePrinter(Invoice invoice){
        this.invoice = invoice;
    }

    public void print()
    {
        //printing format dan desain di sini
    }
}

class InvoiceSaveFile {
    Invoice invoice;

    InvoiceSaveFile(Invoice invoice){
        this.invoice = invoice;
    }

    public void saveToFile(string fileName) {
        // kode untuk membuat file
    }
}