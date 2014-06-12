<?php

class adComAction extends Action{
    var $tiyan,$tylast,$niu;
    function _initialize() {
        $this->assign('PAGE_CURID',2);
        $this->tiyan = D("Tiyan");
        $this->tylast= D("Tiyanlast");
        $this->niu = D("Niu");

        $this->assign('db_tylast',$this->tylast->getTylastList());
        $this->assign('db_slider',$this->tiyan->getSliderList());
        $this->assign('db_niu',$this->niu->getSpecList(null,"data_id=1 or 2"));
    }
}