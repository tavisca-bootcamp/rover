package com.tavisca.workshops.Motions;

import com.tavisca.workshops.Mapper.Directions;
import com.tavisca.workshops.Position.Vector;

public class RightRotate implements IRotate {

    @Override
    public Vector rotate(Vector currentVector) {
        Directions newDirection = currentVector.direction;
        if (currentVector.direction.ordinal() == Directions.values().length - 1)
            newDirection = Directions.values()[0];
        else
            newDirection = Directions.values()[currentVector.direction.ordinal() + 1];
        return new Vector(currentVector.x, currentVector.y, newDirection);
    }
}
