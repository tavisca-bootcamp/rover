package com.tavisca.ebran.rover;

import java.util.HashMap;

public class Vector {
        public final int x;
        public final int y;
        public final char direction;

        public Vector(int x, int y, char direction) {
            this.x = x;
            this.y = y;

            this.direction = direction;
        }

    private static HashMap<Character, Character> leftMap
            = new HashMap<>() {{
        put('N', 'W');
        put('W', 'S');
        put('S', 'E');
        put('E', 'N');
    }};

    private static HashMap<Character, Character> rightMap
            = new HashMap<>() {{
        put('N', 'E');
        put('W', 'N');
        put('S', 'W');
        put('E', 'S');
    }};

    public Vector turnLeft() {
        return new Vector(this.x, this.y, leftMap.get(this.direction));
    }


    public Vector turnRight() {
        return new Vector(this.x, this.y, rightMap.get(this.direction));
    }

    public Vector move() {
        if (direction == 'N')
            return new Vector(this.x, this.y + 1, this.direction);
        else if (direction == 'E')
            return new Vector(this.x + 1, this.y, this.direction);
        else if (direction == 'W')
            return new Vector(this.x - 1, this.y, this.direction);
        else if (direction == 'S')
            return new Vector(this.x, this.y - 1,this.direction);

        return new Vector(this.x, this.y, this.direction);
    }
}
