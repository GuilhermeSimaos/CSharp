class Ponto{
    //Variaveis
    private int x;
    private int y;

    //Construtores
    public Ponto(){

    }
    public Ponto(int x, int y){
        this.x = x;
        this.y = y;
    }
    public Ponto(Ponto p){
        this.x = p.getX();
        this.y = p.getY();
    }

    //Getters e Setters
    public void setX(int x){this.x = x;}
    public void setY(int y){this.y = y;}
    public void setXY(int x, int y){this.x = x; this.y = y;}
    public int getX(){return this.x;}
    public int getY(){return this.y;}

    //Metodos
    public Ponto getPonto(){
        return (Ponto)this.MemberwiseClone();
    }
    public double Distancia(Ponto p1, Ponto p2){
        //Formula para calculo 
        //da distancia entre dois pontos: 
        //Dxy = Sqrt((Xb - Xa)^2 + (Yb - Ya)^2)
        return Math.Sqrt( Math.Pow((p2.getX() - p1.getX()), 2) + Math.Pow((p2.getY() - p1.getY()), 2)); 
    }
}