package PhuongTienGiaoThong;

public class XeDien extends PhuongTien implements IChayDien{
    // thuoc tinh
    private String toc_do_sac;
    public XeDien(String ten_xe, String hang_san_xuat, double toc_do_toi_da, double so_cho_ngoi, String toc_do_sac){
        super(ten_xe,hang_san_xuat,toc_do_toi_da,so_cho_ngoi);
        this.toc_do_sac = toc_do_sac;
    }
    @Override
    public void sacPin() {
        System.out.println("XeDien can duoc sac pin");
    }
    @Override
    public void inThongTin() {
        super.inThongTin();
        System.out.println("XeDien sac pin: "+toc_do_sac);
    }
    @Override
    public String toString() {
        return super.getTen_xe();
    }
    @Override
    public void Chay(){
        System.out.println("XeDien chay tren duong dai");
    }

}
