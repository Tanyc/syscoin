<?php
class GloryViewModel extends ViewModel {
	const PERPAGE = 10;
   	public $viewFields = array(
     	'Glorylist'=>array('id','UID','is_im','title','content','imgs','bbs_num','_type'=>'LEFT'),
     	'User'=>array('nick'=>'u_nick','headimg', '_on'=>'Glorylist.UID=User.id'),
   	);

	public function getResultByPage($page = 1,$isMy){
        $UID = $_SESSION[C('USER_AUTH_KEY')];
        if (isNil($UID)) {
            return null;
        }
        if ($isMy) {
            return $this->where("UID=".$UID)->page($page,$this::PERPAGE)->select();
        }
        return $this->page($page,$this::PERPAGE)->select();
    }

    public function getMyResultByPage($page){
        $page = $page? $page : 1;
        return $this->getResultByPage($page,true);
    }

    public function getAllCount(){
        return $this->count();
    }

    public function getMyCount(){
        $UID = $_SESSION[C('USER_AUTH_KEY')];
        if (isNil($UID)) {
            return null;
        }
        return $this->where("UID=".$UID)->count();
    }

    public function getAllResultByPage($page){
        $page = $page? $page : 1;
        return $this->getResultByPage($page);
    }

}