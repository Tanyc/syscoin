<?php

class loginAction extends Action{
    
    function _initialize() {
        Log::record("loginAction _initialize...");
        // if(!isset($_SESSION[C('USER_AUTH_KEY')])) {
        // 	 redirect(__ROOT__.'/index');
        // }
    }
    
}