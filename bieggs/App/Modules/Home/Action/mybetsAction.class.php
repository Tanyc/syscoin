<?php
class mybetsAction extends loginAction{
    function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',4);
    }

    public function my28(){  //我的投注
        $this->assign('MENU_TAB',1);
        $this->display();
    }

    public function trend28(){  //28走势图
        $this->assign('MENU_TAB',2);
        $this->display();
    }

    public function intr28(){  //28简介
        $this->assign('MENU_TAB',3);
        $this->display();
    }

    public function nrb28(){  //28牛人
        $this->assign('MENU_TAB',4);
        $this->display();
    }

    public function m28edit(){  //28模式编辑
        $this->assign('MENU_TAB',6);
        $this->display();
    }

    public function auto28(){  //28模式编辑
        $this->assign('MENU_TAB',7);
        $this->display();
    }
    
    /*************310*****************/
    public function my310(){
        $this->display("my310");
    }

}