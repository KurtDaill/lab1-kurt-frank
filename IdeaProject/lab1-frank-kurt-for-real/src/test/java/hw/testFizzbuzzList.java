package hw;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import java.util.List;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class testFizzbuzzList {
    private fizzbuzzTestableList fixture;

    @Before
    public void setUp() throws Exception {
        fixture = new fizzbuzzTestableList();
    }

    @After
    public void tearDown() throws Exception {
        fixture = null;
    }

    @Test
    public void fBTestA(){
        assertEquals(null, fixture.fizzBuzz( -10));
    }

    @Test
    public void fBTestB(){
        assertEquals(null, fixture.fizzBuzz( -1));
    }

    @Test
    public void fBTestC(){
        ArrayList tempList = new ArrayList<String>();
        assertEquals(tempList, fixture.fizzBuzz( 0));
    }

    @Test
    public void fBTestD(){
        ArrayList tempList = new ArrayList<String>(Arrays.asList("1"));
        assertEquals(tempList, fixture.fizzBuzz( 1));
    }

    @Test
    public void fBTestE(){
        ArrayList tempList = new ArrayList<String>(Arrays.asList("1", "2", "fizz", "4", "buzz", "fizz", "7"));
        assertEquals(tempList, fixture.fizzBuzz( 7));
    }

    @Test
    public void fBTestF(){
        ArrayList tempList = new ArrayList<String>(Arrays.asList("1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz", "16", "17"));
        assertEquals(tempList, fixture.fizzBuzz( 17));
    }
}
