<?php
class GlorylistModel extends Model {
	const PERPAGE = 10;
	public function getResultByPage($page = 1){
    	if (is_nil($page)) {
    		$page = 1;
    	}
        return $this->page($page,$this::PERPAGE)->select();
    }

    public function getCount(){
        return $this->count();
    }
}