package com.tavisca.workshops.Position;

import com.tavisca.workshops.Mapper.CharacterDirectionToEnumMapper;
import com.tavisca.workshops.Mapper.Directions;
import com.tavisca.workshops.Mapper.EnumToCharacterDirectionMapper;
import com.tavisca.workshops.Motions.RotateDirections;
import com.tavisca.workshops.Motions.RoveForward;

public class Vector {
    public final int x;
    public final int y;
    public final Directions direction;

    public Vector(int x, int y, char direction) {
        this.x = x;
        this.y = y;
        this.direction = CharacterDirectionToEnumMapper.CHARACTER_DIRECTIONS_HASH_MAP.get(direction);
    }

    public Vector(int x, int y, Directions direction) {
        this.x = x;
        this.y = y;
        this.direction = direction;
    }

    public Vector rotate(char command) {
        return new RotateDirections().rotateVectorDirection(this, command);
    }

    public Vector moveForward() {
        return new RoveForward().roveSingleStepForward(this);
    }

    @Override
    public String toString() {
        return this.x + " " + this.y + " " + EnumToCharacterDirectionMapper.DIRECTIONS_CHARACTER_HASH_MAP.get(this.direction);
    }
}
