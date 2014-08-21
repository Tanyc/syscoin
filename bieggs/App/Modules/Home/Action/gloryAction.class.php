<?php
class gloryAction extends comAction{
    function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',8);
    }

    public function index(){
    	$m_tab = $this->_param("extra1");
    	$tab = (is_nil($m_tab))? 0: $m_tab;
        if (1 == $tab) checkIsLogin();
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
        if (checkIsLogin()) {
            $this->assign("m_tab",3);
            $this->display();
        }
    }

    public function newGlory(){
        if (checkIsLogin()) {
            if (!empty($_FILES)) {
                $this->_upload();
            }else{
                $this->error("请选择上传文件");
            }
        }
    }

    // 文件上传
    protected function _upload() {
        import('@.ORG.Util.UploadFile');
        $upload = new UploadFile();
        $upload->maxSize            = 3292200;
        $upload->allowExts          = explode(',', 'jpg,gif,png,jpeg');
        $upload->savePath           = './Uploads/Images/';
        $upload->thumb              = true;
        $upload->imageClassPath     = '@.ORG.Util.Image';
        $upload->thumbPrefix        = 'm_,s_'; 
        $upload->thumbMaxWidth      = '400,100';
        $upload->thumbMaxHeight     = '400,100';
        $upload->saveRule           = 'uniqid';
        $upload->thumbRemoveOrigin  = true;
        if (!$upload->upload()) {
            $this->error($upload->getErrorMsg());
        } else {
            $uploadList = $upload->getUploadFileInfo();
            import('@.ORG.Util.Image');
            $path = $uploadList[0]['savepath'];
            $files = "";
            foreach ($uploadList as $s_file) {
                $fileName = 'm_' . $s_file['savename'];
                if ("" != $fileName) {
                    Image::water($path . $fileName, './Public/logo/logo.png');
                    $files .= $fileName . ":";
                }
            }
            //save glorylist

            $db_glory = D("Glorylist");
            $data            = array();
            $data['UID']     = $_SESSION[C('USER_AUTH_KEY')];
            $data['title']   = $_POST["subject"];
            $data['content'] = $_POST["content"];
            $data['imgs']    = substr($files, 0, -1);
            $data['CTIME']   = time();
            $isadd = $db_glory->addOneItem($data);
            if ($isadd !== false) {
                $this->success('晒奖成功！');
            } else {
                $this->error('晒奖失败!');
            }
            
        }
    }

}