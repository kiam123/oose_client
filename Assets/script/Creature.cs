using System;
using UnityEngine;
using System.Collections.Generic;



    class Creature
    {
        public int kind_no;
        public int owner;
        public int atk;
        public int maxHp;
        public int nowHp;
        public int mov;
        public int thr;
        public int[][] range;
        public String name;
        public String introdice;
        public int waitTime;
        public String[] label = new String[5];
        public Vector2 coordinate = new Vector2();



        public bool canAttack = true;
        public bool canMove = true;
        public bool canSkill = true;
        public bool canTreat = true;//可以被治療
        public bool canBeattack = true;
        public bool canBechoose = true;

        public bool haveMove = false;

        int[][] usingrange;

        public void skill_whenplay() { }
        public void skill_otherplay(Creature newone) { }
        public void skill_whenrebirth() { }//復活時呼叫
        public void skill_otherrebirth(Creature newone) { }

        public void skill_beforemove(Vector2 from) { }
        public void skill_otherbeforemove(Creature mover, Vector2 from) { }
        public void skill_aftermove(Vector2 from, Vector2 to) { }
        public void skill_otheraftermove(Creature mover, Vector2 from, Vector2 to) { }

        public void skill_beforeattack(Creature traget) { }
        public void skill_otherbeforeattack(Creature attacker, Creature traget) { }
        public void skill_afterattack(Creature traget) { }
        public void skill_otherafterattack(Creature attacker, Creature traget) { }

        public damage causedamage(Creature traget, String kind, int amount)
        {
            return new damage(kind, amount);
        }

        public void skill_othercausedamage(Creature causer, Creature traget, damage give) { }

        public void skill_beenattack(Creature attacker) { }
        public void skill_otherbeenattack(Creature attacker, Creature taker) { }
        public void skill_afterbeenattack(Creature attacker) { }
        public void skill_otherafterbeenattack(Creature attacker, Creature taker) { }

        public void takedamage(Creature causer, damage get)
        {
            this.nowHp = this.nowHp - get.amount;
            if (this.nowHp <= 0)
            {
                this.death();
            }

        }
        public void skill_othertakedamage(Creature causer, damage get) { }
        public void betreat(Creature treater, int amount)
        {
            if (canTreat)
            {
                if (nowHp + amount >= maxHp)
                {
                    nowHp = maxHp;
                }
                else
                {
                    nowHp = nowHp + amount;
                }
            }
        }
        public void skill_otherbeentreat(Creature treater, int amount) { }

        public void death()
        {
            frame.destory(this);
        }
        public void skill_otherdeath(Creature defunct) { }
        public void attack()
        {

        }
        public Creature[] gettraget(map[][] map)
        {

        }
        public String toString()
        {
        }
    }

