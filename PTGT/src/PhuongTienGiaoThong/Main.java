package PhuongTienGiaoThong;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

        XeHoi XhToyota = new XeHoi("Xehoithongminh", "Toyota", 200, 4, "nhanh");
        System.out.println("In thong tin xe "+ XhToyota);
        XhToyota.inThongTin();
        XhToyota.doXang();

        XeDien XdVin = new XeDien("XeDien","VinGroup",180,4,"nhanh");
        System.out.println("In thong tin xe "+ XdVin);
        XdVin.inThongTin();
        XdVin.sacPin();

        XeHybrid XhHonda = new XeHybrid("XeHybrid","Honda",200, 4,30,300);
        System.out.println("In thong tin xe "+ XhHonda);
        XhHonda.inThongTin();
        XhHonda.doXang();
        XhHonda.sacPin();

    }
}