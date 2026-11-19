# Git notes

## Task 15 — Basic git

### Commands

Репозиторий создан через Visual Studio (`git init` выполнен автоматически при публикации на GitHub).

```bash
git checkout -b feature/git-basics
# дописал строку в README.md
git add README.md
git commit -m "docs: task 15 - change in feature branch"
git checkout main
git merge --no-ff feature/git-basics -m "merge: feature/git-basics into main"

git checkout -b feature/conflict-a
# заменил первую строку README.md на "# Версия A"
git add README.md
git commit -m "docs: task 15 - readme version A"
git checkout main
# заменил ту же первую строку README.md на "# Версия B"
git add README.md
git commit -m "docs: task 15 - readme version B"
git merge feature/conflict-a
# CONFLICT in README.md: вручную убрал маркеры <<<<<<<, =======, >>>>>>>
git add README.md
git commit -m "fix: task 15 - resolve merge conflict"

git log --graph --oneline --all
git push
```

### Output (git log --graph --oneline --all)

```
*   dee3911 fix: task 15 - resolve merge conflict
|\  
| * 740d36f docs: task 15 - readme version A
* | 696db41 docs: task 15 - readme version B
|/  
*   eb21fa2 merge: feature/git-basics into main
|\  
| * 9336e5a docs: task 15 - change in feature branch
|/  
*   a20401b merge: level 3 into main
|\  
| * 30520bd feat: add menu for levels 2 and 3
| * 8f2b61b feat: task 50 - git bisect
| * 482f8e2 feat: task 49 - git reflog
| * 16e11e4 feat: task 48 - git tags
| * 1ac7033 feat: task 47 - git squash
| * ce634a5 feat: task 46 - git stash
| * df640d5 feat: task 45 - library
| * a72eb21 feat: task 44 - todo list
| * 402485d feat: task 43 - catch order
| * 1c71215 feat: task 42 - cancellation token
| * 1a96de6 feat: task 41 - when all
| * 8b21533 feat: task 40 - async await
| * 764eb3b feat: task 39 - yield even
| * 6c68a21 feat: task 38 - list vs linked list
| * 5f36817 feat: task 37 - fibonacci memo
| * c8ef43e feat: task 36 - duplicates
|/  
*   5f15a0a merge: level 2 into main
|\  
| * 50ba2f6 feat: task 35 - git scenario
| * 9066565 feat: task 34 - linq group words
| * abe2c86 feat: task 33 - linq employees
| * 8ebd4cb feat: task 32 - temperature
| * 597ce5d feat: task 31 - disposable
| * 1c3e89c feat: task 30 - bank account
| * 6ad4b8c feat: task 29 - notification factory
| * b9adcd8 feat: task 28 - point equals
| * 6cf4514 feat: task 27 - student sorting
| * 75fb17f feat: task 26 - discount strategy
| * 9374bb9 feat: task 25 - shapes
| * d4d8883 feat: task 24 - animals
| * fa9365b feat: task 23 - nullable
| * a11aa17 feat: task 22 - params sum
| * d262353 feat: task 21 - enum days
| * 3d63cc2 feat: task 20 - generics
| * 3847f13 feat: task 19 - my stack queue
| * a25e881 feat: task 18 - try parse vs try catch
| * d1b6984 feat: task 17 - string builder vs concat
| * 180924a feat: task 16 - string extensions
|/  
* 5ea6e52 Добавьте файлы проекта.
* 0648a30 Добавить .gitattributes, .gitignore и README.md.
```

### What I learned

Ветка позволяет вести работу отдельно от `main`, а конфликт при merge возникает, когда одну и ту же строку изменили в двух ветках, и его разрешают вручную.

## Task 35 — Branches & PR

### Commands

```bash
git add .gitignore .editorconfig
git commit -m "chore: add gitignore and editorconfig"
git push

git checkout -b feature/task-35
# создал task35-demo.txt и сделал три коммита
git commit -m "feat: task 35 - add demo file"
git commit -m "fix: task 35 - fix demo file"
git commit -m "docs: task 35 - update demo file"
git push -u origin feature/task-35
# Pull Request в main, squash-merge
git checkout main
git pull

git checkout -b feature/rebase-demo
git commit -m "wip: step 1"
git commit -m "wip: step 2"
git commit -m "wip: step 3"
git rebase -i HEAD~3   # второй и третий коммит заменил на squash
git commit --amend -m "feat: task 35 - rebase demo"
git push --force-with-lease origin feature/rebase-demo
```

### PR link

https://github.com/Hamater0/practice/pull/2

### Rebase result

До (`git log --oneline -4`):

```
e0572a3 wip: step 3
b1beb45 wip: step 2
006a3b6 wip: step 1
7d50c12 feat: task 35 - git workflow demo (#2)
```

После (`git log --oneline -4`):

```
68c1f78 feat: task 35 - rebase demo
7d50c12 feat: task 35 - git workflow demo (#2)
4b596eb chore: add gitignore and editorconfig
f3c6800 docs: update readme with task table
```

### What I learned

Pull Request позволяет проверить изменения перед слиянием в `main`, а `rebase -i` с `squash` объединяет несколько мелких коммитов в один и делает историю чище.

## Task 46 — git stash

### Commands

```bash
# изменил отслеживаемый файл task35-demo.txt, не коммитил
git stash
git stash list
git checkout -b feature/stash-demo
git checkout main
git stash pop
git stash list
```

### Output

`git stash list` до `git stash pop`:

```
stash@{0}: WIP on main: b0ee9f0 docs: task 35 - add git notes
```

`git stash list` после `git stash pop` (список пуст):

```
(пусто)
```

### What I learned

`git stash` временно прячет незакоммиченные изменения, `git stash pop` возвращает их и удаляет запись из списка.
