package PhuongTienGiaoThong;

public abstract class PhuongTien implements Chay {
    // thuoc tinh
    private String ten_xe;
    private String hang_san_xuat;
    private double toc_do_toi_da;
    private double so_cho_ngoi;
    // ham dung - constructor
    public PhuongTien(String ten_xe, String hang_san_xuat, double toc_do_toi_da, double so_cho_ngoi) {
        this.ten_xe = ten_xe;
        this.hang_san_xuat = hang_san_xuat;
        this.toc_do_toi_da = toc_do_toi_da;
        this.so_cho_ngoi = so_cho_ngoi;
    }
    // methods
    public void inThongTin(){
        System.out.println("PhuongTien inThongTin");
        System.out.println("Ten xe: " + ten_xe);
        System.out.println("Hang san xuat: " + hang_san_xuat);
        System.out.println("Toc do toi da: " + toc_do_toi_da+" km/h");
        System.out.println("So cho ngoi: " + so_cho_ngoi);
    }
    @Override
    public void Chay()
    {
        System.out.println("Thuoc PhuongTien thi phai chay duoc");
    }
    // getter - encapsulation
    public String getTen_xe(){
        return ten_xe;
    }
}



