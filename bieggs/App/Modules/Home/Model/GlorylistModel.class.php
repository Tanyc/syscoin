<?php
class GlorylistModel extends Model {
	const PERPAGE = 10;
	public function getResultByPage($page = 1,$UID){
    	if (is_nil($page)) {
    		$page = 1;
    	}
        if ($UID) {
            return $this->where("u_id=".$UID)->page($page,$this::PERPAGE)->select();
        }
        return $this->page($page,$this::PERPAGE)->select();
    }

    public function getCount($UID){
        if ($UID) {
            return $this->where("u_id=".$UID)->count();
        }
        return $this->count();
    }
}