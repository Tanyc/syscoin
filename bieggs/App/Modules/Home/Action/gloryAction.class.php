<?php
class gloryAction extends loginAction{
    function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',8);
    }

    public function index(){
    	$m_tab = $this->_param("extra1");
    	$tab = (is_nil($m_tab))? 0: $m_tab;
        $this->assign("m_tab",$tab);

        $pg = $this->_param('pg');
        $glorylist = D("Glorylist");
        if (0 == $tab) { //全部晒奖
            $this->initCom($glorylist->getAllCount(),("" == $pg)? 1 : $pg);
            $this->assign("db_glorylist",$glorylist->getAllResultByPage($pg));
        } else {         //我的晒奖
            $this->initCom($glorylist->getMyCount(),("" == $pg)? 1 : $pg);
            $this->assign("db_glorylist",$glorylist->getMyResultByPage($pg));
        }
        $this->display();
    }

    public function detail(){
        $id = $this->_param('id');  //根据id具体展示

        $glorylist = D("Glorylist");
        $result = $glorylist->getResultById($id);
        $this->assign("db_glory",$result);

        $data = array();
        $UID = $glorylist->getFiledById($id,"UID");
        $db_user = D("User");
        $data["nick"] = $db_user->getFiledByUID($UID,"nick");
        $data["headimg"] = $db_user->getFiledByUID($UID,"headimg");
        $this->assign($data);

        if ($UID == $_SESSION[C('USER_AUTH_KEY')]) {
            $this->assign("m_tab",1);
        }

        $this->display();
    }

    private function initCom($db_data_cnt, $cur_pg){
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $array['items']      = 10; //每页显示的条数
        $this->assign($array);
    }

    public function rule(){
        $this->assign("m_tab",4);
        $this->display();
    }

    public function addnew(){
        $this->assign("m_tab",3);
        $this->display();
    }

}