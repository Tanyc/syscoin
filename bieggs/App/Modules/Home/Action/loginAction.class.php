<?php

class loginAction extends comAction{
    
    function _initialize() {
    	parent::_initialize();
        Log::record("loginAction _initialize..." . strtolower(MODULE_NAME));
        checkIsLogin();
    }

}