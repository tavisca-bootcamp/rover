package com.tavisca.workshops.Position;

public class Coordinates {
    private final int x;
    private final int y;

    Coordinates(int x, int y){
        this.x = x;
        this.y = y;
    }

    public int getX(){
        return this.x;
    }

    public int getY(){
        return this.y;
    }

}
