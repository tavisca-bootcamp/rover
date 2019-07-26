package com.tavisca.workshops.pratham.rover;

import java.util.HashMap;

public class Vector {
    private final int x;
    private final int y;
    private final char direction;

    public Vector(int x, int y, char direction) {

        this.x = x;
        this.y = y;
        this.direction = direction;
    }

    public int x() {
        return x;
    }

    public int y() {
        return y;
    }

    public char direction() {
        return direction;
    }

    private static HashMap<Character, Character> leftmap = new HashMap<>(){{
        put('N', 'W');
        put('E', 'N');
        put('S', 'E');
        put('W', 'S');
    }};

    private static HashMap<Character, Character> rightmap = new HashMap<>(){{
        put('N', 'E');
        put('E', 'S');
        put('S', 'W');
        put('W', 'N');
    }};

    public Vector turnLeft() {
        return new Vector(this.x,this.y, leftmap.get(this.direction));
    }

    public Vector turnRight() {
        return new Vector(this.x,this.y, rightmap.get(this.direction));
    }

    public Vector move() {

        int newX = this.x();
        int newY = this.y();
        switch(this.direction){
            case 'N' : newY++; break;
            case 'E' : newX++; break;
            case 'S' : newY--; break;
            case 'W' : newX--; break;
        }
        return new Vector(newX, newY, this.direction);
    }
}
