package PhuongTienGiaoThong;

public class XeHybrid extends PhuongTien implements IChayXang,IChayDien {
   // thuoc tinh
    private double toc_do_dx;
    private double toc_do_sp;
    public XeHybrid(String ten_xe, String hang_san_xuat, double toc_do_toi_da, double so_cho_ngoi, double toc_do_dx, double toc_do_sp) {
        super(ten_xe,hang_san_xuat,toc_do_toi_da,so_cho_ngoi);
        this.toc_do_dx = toc_do_dx;
        this.toc_do_sp = toc_do_sp;
    }
    @Override
    public void doXang() {
        System.out.println("XeHybrid co the do xang");
    }
    public void sacPin(){
        System.out.println("XeHybrid co the sac pin");
    }
    @Override
    public void inThongTin() {
        super.inThongTin();
        System.out.println(((toc_do_dx)>(toc_do_sp))?("Sac pin nhanh hon do xang"):("Do xang nhanh hon sac pin"));
    }
    @Override
    public String toString() {
        return super.getTen_xe();
    }
    @Override
    public void Chay(){
        System.out.println("XeHybrid chay tren nhieu loai duong");
    }

}
