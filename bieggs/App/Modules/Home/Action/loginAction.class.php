<?php

class loginAction extends comAction{
    
    function _initialize() {
    	parent::_initialize();
        Log::record("loginAction _initialize..." . strtolower(MODULE_NAME));
        if(!isset($_SESSION[C('USER_AUTH_KEY')])) {
        	redirect(__ROOT__.'/pubtpl/nologin');
        }
    }

}