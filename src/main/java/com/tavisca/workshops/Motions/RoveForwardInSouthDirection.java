package com.tavisca.workshops.Motions;

import com.tavisca.workshops.Position.Vector;

public class RoveForwardInSouthDirection implements IRoveForward {
    public Vector roveForward(Vector currentVector) {
        return new Vector(currentVector.x, currentVector.y - 1, currentVector.direction);
    }
}
