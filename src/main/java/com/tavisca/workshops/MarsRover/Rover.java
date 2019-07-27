package com.tavisca.workshops.MarsRover;

import com.tavisca.workshops.Mapper.EnumToCharacterDirectionMapper;
import com.tavisca.workshops.Position.Vector;

public class Rover {
    private Vector vector;

    Rover() {
        vector = new Vector(0, 0, 'E');
    }

    public void setStartingPosition(int x, int y, char direction) {
        vector = new Vector(x, y, direction);
    }

    void rove(String commands) {
        for (char command : commands.toCharArray()) {
            rove(command);
        }
    }

    private void rove(char command) {
        if (command == 'L' || command == 'R')
            this.vector = vector.rotate(command);
        if (command == 'M')
            this.vector = vector.moveForward();

    }

    public String getCurrentPosition() {
        return this.vector.x + " " + this.vector.y + " " + EnumToCharacterDirectionMapper.DIRECTIONS_CHARACTER_HASH_MAP.get(this.vector.direction);
    }
}
