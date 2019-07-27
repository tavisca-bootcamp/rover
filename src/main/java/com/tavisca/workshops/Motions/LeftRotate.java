package com.tavisca.workshops.Motions;

import com.tavisca.workshops.Mapper.Directions;
import com.tavisca.workshops.Position.Vector;

public class LeftRotate implements IRotate {

    @Override
    public Vector rotate(Vector currentVector) {
        Directions newDirection = currentVector.direction;
        if (currentVector.direction.ordinal() == 0)
            newDirection = Directions.values()[Directions.values().length - 1];
        else
            newDirection = Directions.values()[currentVector.direction.ordinal() - 1];
        return new Vector(currentVector.x, currentVector.y, newDirection);
    }
}
