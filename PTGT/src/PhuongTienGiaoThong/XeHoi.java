package PhuongTienGiaoThong;

public class XeHoi extends PhuongTien implements IChayXang{

    // thuoc tinh rieng
    private String toc_do;
    public XeHoi(String ten_xe, String hang_san_xuat, double toc_do_toi_da, double so_cho_ngoi, String toc_do) {
        super(ten_xe,hang_san_xuat,toc_do_toi_da,so_cho_ngoi);
        this.toc_do = toc_do;
    }
    @Override
    public void doXang() {
        System.out.println("Xehoi can duoc do xang");
    }

    @Override
    public void inThongTin(){
        super.inThongTin();
        System.out.println("XeHoi do xang: "+toc_do);
    }
    @Override
    public String toString() {
        return super.getTen_xe();
    }

    @Override
    public void Chay(){
        System.out.println("XeHoi chay tren duong cao toc");
    }

}
