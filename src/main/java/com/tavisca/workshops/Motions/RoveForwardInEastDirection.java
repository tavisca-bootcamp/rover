package com.tavisca.workshops.Motions;

import com.tavisca.workshops.Position.Vector;

public class RoveForwardInEastDirection implements IRoveForward {
    public Vector roveForward(Vector currentVector) {
        return new Vector(currentVector.x + 1, currentVector.y, currentVector.direction);
    }
}
