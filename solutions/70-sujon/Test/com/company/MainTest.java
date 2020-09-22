package com.company;

import org.junit.Test;

import static org.junit.Assert.*;

//test

public class MainTest {

    @Test
    public void getVillageName() throws Exception {
        Main katakhali = new Main("katakhali");
        assertEquals("katakhali", katakhali.getVillageName());
    }
}