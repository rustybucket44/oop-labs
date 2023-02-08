using System;

public class TCyllinder : TCircle{
    public int Height;
	
	//constructors
    public TCyllinder(int _radius, int _height) : base(_radius) {
    	this.Radius = _radius;
		this.Height = _height;
    }
    public TCyllinder() {
    	this.Radius = 0;
		this.Height = 0;        
    }
    public TCyllinder(TCyllinder _cyll0) {
        this.Radius = _cyll0.Radius;
        this.Height = _cyll0.Height;
    }
	//functions
    public void incHeight(int inc){
        int res = this.Height + inc;
        if (res < 0) {
            this.Height = 0;
        }else{
            this.Height = res;
        }
    }
    
    public void mulHeight(double mul){
        this.Height = (int)Math.Round(this.Height*mul);
    }
    
    public int getVolume(){
        return (int)Math.Round(this.Height*Math.PI*this.Radius*this.Radius);
    }
    
	public override int getArea(){
	    return (int)Math.Round(2*Math.PI*this.Radius*(this.Radius+this.Height));
	}
};