<?php

class comAction extends Action{
    var $dj_slider; //兑奖slider显示
    function _initialize() {
        Log::record("comAction _initialize...");
        $this->dj_slider = D("Duijiang");

        $this->assign('db_dj_slider',$this->dj_slider->getSliderList());
    }
    
}